using System;

public class TemperatureExceededEventArgs : EventArgs
{
    public double Temperatura { get; set; }

    public TemperatureExceededEventArgs(double temperatura)
    {
        this.Temperatura = temperatura;
    }
}


public class TemperatureSensor
{

    public event EventHandler<TemperatureExceededEventArgs> TemperatureExceeded;

    public void MonitoradorDeTemperatura(double temperaturaLida)
    {
        if (temperaturaLida > 100)
        {
            TemperaturaExcedida(temperaturaLida);
        }
    }

    protected virtual void TemperaturaExcedida(double temperatura)
    {
        TemperatureExceeded?.Invoke(this, new TemperatureExceededEventArgs(temperatura));
    }
}



